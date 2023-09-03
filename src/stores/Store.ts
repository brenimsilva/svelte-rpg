import { writable } from "svelte/store";
import type { BattleLogType } from "../classes/Types";


export const battleLogW = writable<BattleLogType[]>([]);