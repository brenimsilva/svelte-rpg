import type Player from "./Player";

export type BattleLogType = {
    from: Player;
    to?: Player;
    action: string;
    ammount?: number;
}

