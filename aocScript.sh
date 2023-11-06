#!/bin/bash

day=$(date +%d)
year=$(date +%Y)

if [ -n "$1" ]; then
    day="$1"
fi
if [ -n "$2" ]; then
    year="$2"
fi

aocpath="$HOME/Documents/Git/Private/AdventOfCode"
cd $aocpath

dotnet new sln -o "$aocpath/$year" -n aoc_"$year"

template_name="Advent Of Code: Starter Template"
if dotnet new list | grep -q "$template_name"; then
    echo "Template '$template_name' found."
else
    dotnet new install "$aocpath/Template/"
fi

dotnet new aocstarter -o "$aocpath/$year/day_$day" -n "day_$day"

cd "$aocpath/$year/day_$day"
sed -i '1c\// Challenge link: https://adventofcode.com/'"$year"'/day/'"$day" Program.cs

cd "$aocpath/$year/day_$day/modules"
aoc download -d "$day" -y "$year" -I
mv "input" "input.txt"

cd "$aocpath/$year/"
dotnet sln aoc_"$year".sln add day_"$day"/day_"$day".csproj
dotnet new gitignore