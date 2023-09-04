import type Player from "./Player";
import { battleLogW, playerMonsterW } from "../stores/Store";
import type { BattleLogType } from "./Types";

export type IAttackStats = {
    min: number;
    max: number;
    chance_rate: number;
}
export default class Battle {
    private player: Player;
    private monster: Player;
    constructor(player: Player, monster: Player) {
        this.player = player;
        this.monster = monster;
        battleLogW.set([]);
    }

    calcDamage(atk: number, def: number) {
        return atk - (def*atk)/100
    }

    update(p: Player, ammount: number) {
        p.stats.hp -= ammount;
        if(p.stats.hp < 0) {
            p.stats.hp = 0;
            battleLogW.update(prev => [...prev, ])
        } else if(p.stats.hp > p.stats.max_hp) {
            p.stats.hp = p.stats.max_hp;
        }
    }

    getBattleStatus() {
        return {player: this.player, monster: this.monster}
    }

    turn() {
        const p_dmg = this.calcDamage(this.player.stats.atk, this.monster.stats.def);
        this.update(this.monster, p_dmg);
        const m_dmg = this.calcDamage(this.monster.stats.atk, this.player.stats.def);
        this.update(this.player, m_dmg);
        this.updateLog(p_dmg, m_dmg, "Attacked", "Attacked");
        playerMonsterW.set(this.getBattleStatus());
    }

    updateLog(p_ammount: number, m_ammount: number, p_action: string, m_action: string) {
        battleLogW.update(prev => [...prev, {from: this.player, to: this.monster, action: p_action, ammount: p_ammount}]);
        battleLogW.update(prev => [...prev, {from: this.monster, to: this.player, action: m_action, ammount: m_ammount}]);
    }

    calcAttackStats(): IAttackStats {
        // return {
        //     chance_rate: this.player.attributes.dex * (this.monster.stats.evs / 100),
        //     min: 
        // }
    }
}