import { Action, type BattleLogType } from "./Types";

export default class Logger {
    constructor() {}

    static buildLog(log: BattleLogType) {
        switch(log.action) {
            case Action.DEATH: {
                this.buildDeath();
                break;
            }
            case Action.DROP: {
                break;
            }
            case Action.POTION: {
                break;
            }
            case Action.SKILL_BUFF: {
                break;   
            }
            case Action.SKILL_OFFENSIVE: {
                break;
            }
            case Action.SLASH: {
                break;
            }
            case Action.STAB: {
                break;
            }
            default: {
                break;
            }
        }
    }

    static buildDeath() {
        return {} as BattleLogType;
    }
}