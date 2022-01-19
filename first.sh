# This is a comment. We use the hashtag to write comments in the command line

# Variables
# A way to store information for use at a later time
# Lets create a variable in this shell script
rhea="A big ole doggy"
# How can we use this variable in shell scripting
# with a dollar sign and also do not use spaces
echo $rhea

# Control Flow
# conditional statements
# A way to tell the program what line of code to run for what situation
# or how many time we want a line of code to run
# run this until the condition is false

# IF Statements
# need spaces b/w if and square brackets and after
ten=10
five=5
fifteen=15

echo "===First IF==="
if [ "$ten" -ge "$five" ]
then
echo "greater!"
echo "$ten > $five"
fi

echo "===second IF==="
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
echo "$five > $ten"
fi

echo "===Third if==="
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
echo "$five > $ten"
elif [ "$ten" -ge "$five" ]
then
echo "greater!"
echo "$ten > $five"
fi

#echo "===Fourth if==="
#if [ "$five" -ge "$ten" ]
#then
#echo "Lesser"!
#echo "$five > $ten"
#elif [ "$ten" -ge "$fifteen" ]
#echo "$ten > $fifteen"
#else
#echo "Nothing works"
#fi
# Loop statements
# The loop will run as long as the condition is true

# FOR LOOP
# useful if you know how many times you need the code within the loop to run
# loop through the for loop five times
echo "===For Loop==="
for num in 1 2 3 4 5
do
echo "repeating"
echo $num
done


# While Loop
#Will repaeat the code until condition is true
# Useful when you are not sure how many time you need to code
# useful for dealing with user input

echo "===While loop==="
while [ "$ten" -ge "$five" ]
do
echo "Greater!"
echo $five
five=$(($five+1))
done


# We can ask for input from the user

echo "What is your name?"
#read name
echo "Hello $name, Welcome to shellscripting"


# We are going to combine all this to create amenu-like interface of
#our terminal that will ask the user info and process that info

repeat="true"

while [ "$repeat" == true ]
do
echo "Welcome to shel script!"
echo "What do you want to do today?"
echo "enter 1 fi you want to add two numbers"
echo "enter 2 if you want to exit out of the program"
read answer

if [ "$answer" == "1" ]
then
echo "Give me two numbers"
read num1
read num2
echo "this is your number $(($num1+$num2))"
echo "Press enter if you want to continue"
read
elif [ "$answer" == "2" ]
then
echo "Goodbye"
repeat="false"
else
echo "Command not found"
fi
clear
done
