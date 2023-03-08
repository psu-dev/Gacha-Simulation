Gacha Simulation Console App - Further Information

Welcome to the Gacha Sim! This was an exercise undertaken to build the pull system utilised in gacha games
one step at a time to explore and understand how they work, alongside creating a fully functioning system which
could be incorporated to a later project in Unity. The general idea is observing how many pulls it takes to obtain
a rare 5* pull, with some other features included along the way.

There are six versions of the simulation, with each iteration increasing in complexity and functionality.
There are brief descriptions within the application before you select them, but this file will serve to provide
greater insight into each simulation: functionality, thought process during and source of inspiration.

Each simulation records the key information to a file for future reference, which can be found here:

GachaSim\bin\Debug\net6.0\Results.txt


Simulations:

1. Basic Simulation

The process in its simplest form; once instantiated, the function will observe a number produced through a random
number generator based on the system clock, from 0 to 99. The rate for a 5* pull has been set to 5% in this example,
meaning that if the value produced exceeds 94, then a 5* pull has been obtained. The function records how many pulls
were conducted to do so and ends the process. This of course isn't an accurate reflection of how gacha games operate,
however this is the core idea which is then built upon with more layers and observations made.


2. Basic Step Simulation

This simulation aims to incorporate another key element to almost all prevalent gacha games on the market: multiple
methods of rolling. Basic Step Simulation was to place the functioning steps in, either a single or ten pull. The user
is prompted with a choice once the function is instantiated, to which the system uses the Basic Simulation process
either once or ten times in a row, then prompts the user once again for their next choice, until the 5* pull is obtained.
It keeps track the current pulls conducted and keeps the user updated, then also informs the user when a 5* occurs and
ends the process.


3. Standard Step Simulation

Once again implementing key gacha functionality, Standard Step Simulation brings varying item rarities to the pull
possibilities through extra checks to the randomly generated number. There are a multitude of ways this is done dependent
on the game, however the most common method is 3* or common items as standard, with 4* or uncommon items at a rate
varying from 10-25%, and the rare 5* previously implemented. This simulation makes three checks to each generated number
and produces the corresponding output, letting the user know and writing to the log. 5* rates are still set at 5%, while
4* rates are 25% and 3* rates are the remaining 70%.


4. Standard Pity Simulation V1

Two version of the Standard Pity Simulation were made to cover different approaches to what is known as the 'pity' system
in gacha games. The pity system guarantees the user certain outcomes so long as they meet certain conditions. 4* and 5*
pity are both common, with 4* pity typically granted after 10 pulls have been made without a 4*, and 5* pity being dependent
on the game and the rates. The two versions focus on different methods of implementing this. V1 grants the user a guaranteed
4* in 10 pulls made, but only when the ten pull function is used: it does not apply for single pulls. The 5* pity has a condition
such that after 50 pulls, the 5* rate increases by 2% per pull made from then on. For example, the 5* rate has been set to 2%,
meaning that when the user reaches 60 pulls without obtaining one, the pull rate of the 61st pull will be 22%.


5. Standard Pity Simulation V2

V2 has a more lenient 4* pity system, such that single pulls are taken into account: if 9 pulls are conducted either in singles
or during a ten pull, a 4* will be given on the next pull. The 5* system has a hard cap at 50 pulls, meaning that if it hasn't
been obtained already, the 50th pull will be a 5*. The same base rates are applied between the two versions: 25% 4* rate and 2%
base 5* rate.


6. Advanced Simulation

The final and most complex simulation, Advanced Simulation implements a 5* pity method from the most popular gacha game Genshin
Impact, as well as some user customisation and adjustments to random number generation. Genshin Impact has what is referred to
as 'hard pity' and 'soft pity', such that the hard cap for a 5* is 90 pulls, but users noticed a large increase in 5* pulls rates
from the 73 pull mark and onward. This is due to a rate increase from the soft pity mark as implemented in Standard Pity
Simulation V1, but advertised as the V2 method.

Because this was already implemented in V1, additional features were added such that the user could input the hard pity and 5* 
pull rates desired, such that soft pity and the rate scaling would be calculated from the inputs. Soft pity was set as 75% of 
hard pity, with the rate scaling calculated by subtracting the pull rate from 100, then dividing that value by the difference 
between hard and soft pity. 4* rates were adjusted to 10%, while keeping the same pity system as V2.

The random number generation was scaled from 0-99 to 0-999, to allow for single decimal point pull rates (e.g 1.5%). The Random
function was also instantiated through getting a hash code from the GUID, rather than just off the system clock, providing an
alternate method to produce a different kind of randomness.
