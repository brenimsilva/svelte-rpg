interface IPlayer {
    levelSystem: ILevelSystem;
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
    max_hp: number;
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

interface ILevelSystem {
    level: number;
    exp: number;
    exp_next_level: number;
    sp: number;
    ap: number;
    pp: number;
}

export type {IPlayer, IStats, IAttributes, ISprite, ILevelSystem};

export default class Player {
    name: string;
    stats: IStats;
    attributes: IAttributes;
    levelSystem: ILevelSystem
    sprite: ISprite;
    constructor(name: string, stats: IStats, attributes: IAttributes, sprite: ISprite, levelSystem: ILevelSystem){
        this.stats = stats;
        this.attributes = attributes;
        this.sprite = sprite;
        this.levelSystem = levelSystem;
        this.name = name;
    }


}
