import { writable, readable } from "svelte/store";
import type { BattleLogType } from "../classes/Types";
import  type Player from "../classes/Player";
import type Battle from "../classes/Battle";

type playerMonster = {
    player: Player,
    monster: Player
}

export const battleLogW = writable<BattleLogType[]>([]);
export const battleW = writable<Battle>();
export const playerMonsterW = writable<playerMonster>();
