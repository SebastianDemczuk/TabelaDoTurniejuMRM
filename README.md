# Tabelka do turniejów (Not finished yet)
Hello. This is software for displaying a table during tournaments. The project was carried out to create a table displaying the results of matches organized by the ***Młodzieżowa Rada Miasta Biała Podlaska***.

## Requirements
They are so small that it is enough to know that the program requires .NET Framework version 4.8

## What's included in this program?
The program includes:
1. First of all, **Menu with a table**, which must be selected in the OBS settings to display
2. **Basic time modification** (starting, pausing, resetting, entering the time *(if it would not be consistent with the actual situation)*)
3. **Basic team modification**, which are referred to as *Gospodarze* and *Goście* (setting their names, the ability to add/subtract points, and setting how many points are to be added/subtracted)
4. **Basic table modification** (Changing the table color, font, and changing the background color from green to another)
5. **Log**, which can facilitate documentation of the course of the match

# Description of windows
## LeMenu
This is the regular menu that manages the points table. It contains settings for *Hosts*, *Guests*, *Table* and **Time**.

## Info
A simple little form. Contains information about the author.

## PointTable
This is a points window that must be launched in *LeMenu* (via MdiTabControl). It contains several labels that display information about the progress of the match.

## Log
*I will describe later.*

## GospodarzeGlobalSettings
*I will describe later.*

## GoscieGlobalSettings
*I will describe later.*
