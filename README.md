# Unity 2D Platformer (Portfolio Project)

This project is a 2D platformer game developed using Unity (C#) as a portfolio piece for a game development internship application.

# Project Purpose

The primary goal of this project is to demonstrate core competencies in the Unity engine and the C# language. The project includes all the fundamental mechanics that constitute a "core gameplay loop".


# Core Features

* **Physics-Based Character Controller:** Fluid movement and jumping implemented using `Rigidbody2D`.
* **4-Way Sensor System:** A jump system based on `Physics2D.OverlapCircle` that can detect the ground from all 4 surfaces (bottom, top, right, left), even if the character rotates.
* **Camera Follow:** A simple and smooth `LateUpdate` camera script that follows the player.
* **Scoring & Collectibles:** "Coin" collection using `OnTriggerEnter2D` and a `GameManager` to update the score to the UI using **TextMeshPro**.
* **Win Condition:** The player can trigger a "You Win!" screen (`SetActive(true)`) by touching a "FinishLine" object.

  
# Management & Scripts

This project adheres to the Separation of Concerns principle. The main scripts are:

* **`PlayerController.cs`**: Manages all player input (`Input.GetAxis`), movement physics (`rb.velocity`), and the 4-way jump sensor logic.
* **`CameraController.cs`**: Uses `LateUpdate()` to ensure the camera follows the player (target) without jitter.
* **`GameManager.cs`**: Acts as the "brain" of the game. It holds the score, references UI elements (ScoreText, WinText), and updates them.
* **`Collectible.cs`**: The script for "Coin" objects. It detects collision with the player (`CompareTag("Player")`) and signals the `GameManager` to add score.
* **`LevelFinish.cs`**: Detects when the finish line is touched, tells the `GameManager` to show the win screen, and also disables player movement (`PlayerController.enabled = false`).


# Setup and How to Run

1.  Clone this repository.
2.  Open the project via Unity Hub.
3.  Open the main scene located in `Assets/Scenes/`.
4.  Press the Play button.
