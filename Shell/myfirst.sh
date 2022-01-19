#!/bin/sh.
echo "Do you want to adventure?"
echo "type yes or no"
read choice
if [ "$choice" == "yes" ]
then
echo "Type the name of the character you would like to be!"
echo "1: Finn"
echo "2: Jake"
echo "3: Princess BubbleGum"
echo "4: Marceline"
read character

if [ "$character" == "Finn" ]
then
echo "You have chosen to be the human Finn!"
elif [ "$character" == "Jake" ]
then
echo "You have chosen to be the magic dog Jake!"
elif [ "$character" == "Princess BubbleGum" ]
then
echo "You have chosen to be the candy elemental Princess BubbleGum!"
elif [ "$character" == "Marceline" ]
then
echo "You have chosen to be Marceline the Vampire Queen!"
else
echo "Not a valid choice"
fi
elif [ "$choice" == "no" ]
then
echo "Maybe you are tired"
fi
echo "Awesome $character, where would you like to adventure?"
echo "1: Nightosphere"
echo "2: Ice Kingdom"
echo "3: Fire Kingdom"
echo "4: Candy Kingdom"
read location

if [ "$location" == "Nightosphere" ]
then
echo "Whatch out for that Hunson Abadeer"
elif [ "$location" == "Ice Kingdom" ]
then
echo "The Ice King is a wacky dude!"
elif [ "$location" == "Fire Kingdom" ]
then
echo "Maybe the Flame Princess will have a rap battle with you"
elif [ "$location" == "Candy Kingdom" ]
then
echo "Everything is candy, but do not eat the candy people"
fi
#echo "You $character have chosen to fight $monster on your adventure!"
