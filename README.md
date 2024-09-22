# Strategy Pattern With Unity
This Unity project demonstrates a basic implementation of the Strategy Pattern applied to a skill system. The project includes three different skills (Fireball, IceBlast, and Shield), each with its own behavior, cooldown management, and animation triggers. This example is designed to provide a clear understanding of how the Strategy Pattern can be applied in Unity.

## Watch:
![Strategy_Pattern](https://github.com/user-attachments/assets/12c3873f-68af-4c30-8844-cf780138382a)

## UML Diagram
![Pattern_GIF (1)](https://github.com/user-attachments/assets/381eb2ae-4d8c-4e83-be8d-447477d74dda)

## What is the Strategy Pattern?
The Strategy Pattern is a behavioral design pattern that enables selecting an algorithm's behavior at runtime. Instead of implementing multiple versions of an algorithm within a single class, the Strategy Pattern allows you to define a family of algorithms or behaviors, each within its own class, and switch between them dynamically.

For example, in this project, different skills like Fireball, IceBlast, and Shield are implemented as separate strategies. This allows the player to use any of these skills without the core player logic needing to change.

## What Does it Provide?
- **Flexibility:** TThe Strategy Pattern allows changing the behavior (algorithm or functionality) of an object either before it is created or at runtime. For example, in a game, you can easily swap abilities or behaviors without rewriting the code, making it more flexible and adaptable.

- **Ease of Maintenance:** By separating each behavior (strategy) into its own class, the code becomes more modular. This makes it easier to add new functionality or update existing behavior without affecting other parts of the code. Changing one strategy doesn't impact others.
- **Open/Closed Principle:** The Strategy Pattern allows you to add new behaviors (strategies) without modifying the existing code. This makes your code open for extension but closed for modification. Adding a new strategy doesn't affect the existing ones, maintaining the integrity of the code.

- **Dynamic Behavior:** The Strategy Pattern allows switching between different strategies at runtime, enabling dynamic behavior changes. For example, a character can switch between different skills or behaviors during gameplay, simply by changing its strategy.

## Project Structure
- **SkillStrategy:** Abstract base class for defining different skill behaviors.
- **FireBallSkill, IceBlastSkill, ShieldSkill:** Concrete implementations of different skills with unique behaviors.
- **AnimationTrigger:** ScriptableObject used to manage animation triggers dynamically.
- **Player:** Manages skill usage and input.
- **ProjectileMovement:** Controls projectile movement.
- **ObjectDestructor:** Automatically destroys skill objects after a set amount of time.

## Project Limitations
This project is intentionally designed as a simplified example to illustrate the core principles of the Strategy Pattern. Therefore, it does not include advanced optimization techniques such as Object Pooling (to manage and reuse objects for performance), nor does it provide advanced UI feedback systems such as cooldown bars or button states. These features can be easily added later to extend the project for production-level use.

## Requirements
- Unity 2020.3 or later

- ## How to Use
1. Clone this repository to your local machine:
    ```bash
    git clone https://github.com/your-username/your-repository.git
    ```

2. Open the project in Unity.

3. Press Play to test the skill system.

