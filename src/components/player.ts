interface IPlayer {
    sp: number;
    stats: IStats;
    attributes: IAttributes;
    sprite: ISprite;
}

interface ISprite {
    url: string;
    width: number;
    height: number;
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

export type {IPlayer, IStats, IAttributes, ISprite};

export default class Player {
    stats: IStats;
    attributes: IAttributes;
    sp: number;
    sprite: ISprite;
    constructor(stats: IStats, attributes: IAttributes, sp: number, sprite: ISprite){
        this.stats = stats;
        this.attributes = attributes;
        this.sp = sp;
        this.sprite = sprite;
    }


}
