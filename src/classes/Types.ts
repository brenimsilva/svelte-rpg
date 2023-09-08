import type Player from "./Player";

export type Drop = {
    name: string;
    ammount: number;
}

export type BattleLogType = {
    from: Player;
    to?: Player;
    action: Action;
    ammount?: number;
    drop?: Drop;
}

export enum Action {
    SKILL_CURE = "Healed",
    SKILL_BUFF = "Buffed",
    SKILL_OFFENSIVE = "Dealt",
    STAB = "Stabbed",
    SLASH = "Slashed",
    POTION = "Healed",
    DEATH = "Died",
    DROP = "Dropped"
}

