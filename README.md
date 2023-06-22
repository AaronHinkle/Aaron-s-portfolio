
﻿# BlackJack

# 1-Person Blackjack Game

This is a simple 1-person blackjack game implemented in C#. The game allows a single player to play a simplified version of the popular casino card game, blackjack, against the computer.

## Game Rules

The objective of the game is to have a hand with a total value higher than the dealer's hand, without exceeding 21. A secondary objective is to amass as many "chips" as the player can, while avoiding the unfortunate end result of running out! The game follows these rules:

1. The player and the dealer are each dealt two cards.
2. The player can see both of their cards but can only see one of the dealer's cards.
3. Face cards (Jack, Queen, King) have a value of 10, and Ace can be either 1 or 11.
4. The player can choose to "hit" to receive an additional card, or "stand" to stop receiving cards.
5. If the player's hand exceeds 21, they lose the game immediately (bust).
6. After the player stands, the dealer reveals their hidden card.
7. The dealer will hit until their hand value reaches 17 or higher.
8. If the dealer's hand exceeds 21, they lose the game (bust).
9. If neither the player nor the dealer busts, the hand with the higher total wins.
10. If both hands have the same total, it's a tie (push).
