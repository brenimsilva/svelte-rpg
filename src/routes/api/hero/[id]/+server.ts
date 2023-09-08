export async function GET({params}) {
    const res = await fetch(`https://dummyjson.com/posts/${params.id}`);
    const data = await res.json();
    return new Response(JSON.stringify(data));
}