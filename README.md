# <span style="color:#E91E63">H</span>eroMining 

## Overview

HeroMining is a simple in use to calculate cryptocurrency mining software. It takes full advantage of modern graphics cards with  no developer fee, make our product one of the best publicly available miners.

## Features
Calculate Cryptocurrency mining revenue.
Mining Cryptocurrency both auto btc mode nor specific coin mode.
What coins the best mining now?
Which pool to mining?
Which Exchange to sell the best price?
How much revenue per day? (Now support thai baht, Usd is implementing)

Developer fee is 0%

## Download

1. download https://github.com/soemsri/HeroMining/releases
2. extract .rar file
3. edit myrig.json
4. run HeroMining.bat

## Supported Pool

- bsod.pw
- gos.cx
- icemining.ca
- phi-phi-pool.com
- zergpool.com
- zpool.ca
- ahashpool.com
- blockmaster.co
- other is implemeting

## Supported Exchange

- crypto-bridge
- cryptopia
- crex24
- bx
- binance
- other is implementing

## Hardware Support

- Nvidia 1080ti
- Nvidia 1070ti
- Nvidia 1070 
- Nvidia 1060
- Nvidia 1050ti
- AMD Rx Vega 64
- AMD Rx Vega 56
- AMD Rx 580
- AMD Rx 570
- AMD Rx 480
- AMD Rx 470

## QuickStart

The current version of HeroMining is a (portable) console application. Unpack the downloaded archive and edit one of the sample `.bat` files or provide the necessary command line arguments.

Example:

```
Dotnet HeroMiningCLI.dll -f <filename.csv> -g <VALUE> -debug 
```

## Command-Line Arguments

`-h`, `-help` help information

`-f` Specify a filename to export .csv file for excel 

`-g` Filter only coins get revenue greather <VALUE> than specify

`-m` Monitor a specific coin. example -m rvn

`-t` Show number of coin that will receive mining per day

`-c` calculate fiat currency revenue to usd or baht. example -c usd or -c baht

`-dig` run miner with the best price. example -dig miner.json

`-debug` Display debug message

## System Requirements

- Windows 64 bit with .NET Core Runtime 2.1 you can download here https://www.microsoft.com/net/download/thank-you/dotnet-runtime-2.1.3-windows-hosting-bundle-installer
(Linux is implementing)
- 2 GB RAM (4 GB recommended). 
- Internet connection

### Windows

- Windows 7/8.1/10 (64-bit versions)
- .NET Core runtime 2.1 https://www.microsoft.com/net/download/thank-you/dotnet-runtime-2.1.3-windows-hosting-bundle-installer

### Linux

- Implementing

## Troubleshooting

### Antivirus Software Reports

HeroMining is not a piece of malicious software. You may try to add an exception in antivirus software you use.

### Invalid Calculate Issues

Some pool can mining with solo mode but doesn't not return hashrate of solo mode so please recheck coin is not solo mode because the revenue is calculate from whole hashrate.

## Contact

If you have problems, questions, ideas or suggestions, please contact us by posting to https://www.facebook.com/fatherofsuperhero

## Facebook

Visit the Crypto Miner group on facebook for the latest news and downloads: [https://www.facebook.com/groups/695312007492162/](https://www.facebook.com/groups/695312007492162/)

## Donate
Donate: Doge coin address
DRWXGGttaY9bGY4Zh53m76kg4xAqZri15S


