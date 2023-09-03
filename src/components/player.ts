interface IPlayer {
    sp: number; // Stat points 
    pp: number; // Perk points
    ap: number; // Ascension points
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
    atk: number;
    def: number;
    evs: number; // Evasion
    crtc: number; // Crit Chance %
    crtd: number // Crit Damage %
}

interface IAttributes {
    str: number;
    vit: number;
    dex: number;
    agi: number;
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
