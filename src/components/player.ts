interface IPlayer {
    sp: number;
    stats: IStats;
    attributes: IAttributes;
}

interface IStats {
    hp: number;
    mp: number;
    atk: number;
    def: number;
}

interface IAttributes {
    dex: number;
    agi: number;
    vit: number;
    int: number;
}

export type {IPlayer, IStats, IAttributes};

export default class Player {
    private stats: IStats;
    private attributes: IAttributes;
    private sp: number;
    constructor(){
        this.stats = {atk: 1, def: 0, hp: 10, mp: 0}
        this.attributes = {agi: 0, dex: 0, int: 0, vit: 0}
        this.sp = 1;
    }


}
