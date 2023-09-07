import { SECRET_API_KEY } from '$env/static/private';

export async function GET({request, url}) {
    const authHeader = request.headers.get("Authorization") as string;
    if(authHeader !== SECRET_API_KEY) {
        return new Response(JSON.stringify({message: "Invalid Credentials"}), {status: 401});
    }
    const take = Number(url.searchParams.get("take") ?? '10');
    const skip = Number(url.searchParams.get("skip") ?? '0');
    const res = await fetch(`https://dummyjson.com/posts?limit=${take}&skip=${skip}`);
    const data = await res.json();
    return new Response(JSON.stringify(data), {status: 200});
}

export async function POST({request, url}) {
    const authHeader = request.headers.get("Authorization") as string;
    if(authHeader !== SECRET_API_KEY) {
        return new Response(JSON.stringify({message: "Invalid Credentials"}), {status: 401});
    }
    const body = await request.json();
    console.log(body);
    return new Response(JSON.stringify(body), {status: 201});
}