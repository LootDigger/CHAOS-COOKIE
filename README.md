**Welcome to our cake coding challenge!**

In the project, you will find a simple game with falling cakes which the player has to avoid by moving the monster left and right.

Game Menu             |  Example Gameplay
:-------------------------:|:-------------------------:
<img src="Screenshots/menu.png" width="30%"> | <img src="Screenshots/gameplay.png" width="30%">

**Submission details**

Please create a private repo by using this one as a template. Use this button on top of the page to do so (you'll need to be logged in):
![template button](Screenshots/template-button.png)

Solve the challenge, create a PR in your copy and add [@itsbeatka](https://www.github.com/itsbeatka) to it when you're ready with your solution.

**Task overview**

We would like you to introduce a temprary limit to how long the user can play. We measure the length of a play session in the number of avoided cakes.

After a cooldown period, the player should be able to resume playing until hitting the limit again. 

In a real game, the player should be able to skip the limit by watching an ad. Please include a button for *"Instant refresh"* but there's no need to add any ad integration in this task.

**Detailed description**

- Allow the user to dodge 10 cakes
- The cooldown period is 60s
- After the 10th cake, pause the game and show a dialog with following elements:
  - a title saying *"You've reached your cake limit!"*
  - a countdown timer with a message *"Wait 00:01:00 to restore it"* below the title (the timer should be counting down from the full duration of the cooldown period to 0)
  - a button with a title *"Instant refresh"* that skips the wait instantly
- Upon reaching 0 on the timer or clicking on the *"Instant refresh"* button, the dialog should be dismissed and the user should be able to continue playing for another 10 cakes

<img src="Screenshots/round-limit.png" align="right" width="20%">


There's no need to style the dialog in any particular way, you can use the default styles for the UI. 

If you want, you can use the following screen from Squarelets as an inspiration but there's **no need to style the UI** to match it.

**Important**
1. Create a set of tests for the cake limit logic.
2. Make sure both the number of cakes to dodge and the cooldown period are easily configurable and ready to be set remotely (you don't have to create a system for remote configuration, a stub / mock implementation with notes on you'd do it is enough).
3. What parts of the design of the existing game could be improved? How? Focus primarily on the technical aspects, such as performance issues or memory management.
4. How would you change the game state management to allow for multiple save slots and syncing with backend? Create a minimal working example to illustrate this.
5. How would you restructure the project to work with a depencency injection system? What kind of services would help to make it more modular? You don't have to create or integrate with one but describe your approach.
6. Is there anything else that could be improved? Both from the technical or game design standpoint.

Feel free to modify the existing project as you see fit to illustrate your points.

If you have any questions reach out to careers@chaoscookie.games.

Good luck!
