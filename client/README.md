## Developing

Instale todas as dependências com o comando `npm install` (or `pnpm install` or `yarn`), start no server em DEV:

```bash
npm run dev

# Ou start o server e abra em uma nova aba
npm run dev -- --open
```

## Game

- [Character](#character)
    - [Level](#level)
    - [Skills](#skills)
    - [Stats](#stats)
    - [Attributes](#attributes)
    - [Perks](#perks-arvore-de-passivas)
    - [Ascension](#ascension)
- [Monster](#monster)
    - [Drop](#drop)
    - [Progression](#progression)

## Character

### Level
- Ao matarmos monstros ganhamos experiência(**exp**)
- Juntamos **exp** para aumentarmos o nível
- Ao subir de nível ganhamos pontos para distribuir em stats. _Stats Points_ (**sp**)
- Ao subir de nível ganhamos um _Perk Point_ (**pp**) 

### Skills
- Você pode selecionar 1 skill por batalha
- Essa skill terá um cooldown em turnos
### Stats
- Health Points **(HP)**
- Max Health Points **(MAX_HP)**
- Attack **(ATK)**
- Defense **(DEF)**
- Evasion **(EVS)** 
- Crit Chance **(CRTC)**
- Crit Damage **(CRTD)**
### Attributes
- Strength **(STR)**
- Vitality **(VIT)**
- Dexterity **(DEX)**
- Agility **(AGI)**

### Perks (Arvore de passivas)
- ^ ATK (%)
- ^ DEF (%)
- ^ HP (%)
- ^ EVS (%)
- ^ CRTC (%)
- ^ CRTD (%)
- Desconto no Shop
- Velocidade de Training
### Ascesion
- Reseta o personagem para o nível 1
- ? Equipamento reseta
- Perks resetam
- Ganha Ascension Points **(AP)**
- Arvore de passivas Ascension

---
## Monster
### Drop
### Progression
---

## Mechanics
### Battle Mechanics
- Damage Calc = P_ATK - (M_DEF * P_ATK) / 100


