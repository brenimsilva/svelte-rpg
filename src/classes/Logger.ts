import type { BattleLogType } from "./Types";

export default class Logger {
    constructor() {}

    static buildLog(log: BattleLogType) {
    }
    static buildDeath() {
        return {} as BattleLogType;
    }
}