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
echo "Awesome $character you are going to ad!"
#echo "1: Hunson Abadeer"
#echo "2: Ice King"
#echo "3: GOLB"
#echo "4: Peace Master"
#read monster

#echo "You $character have chosen to fight $monster on your adventure!"
