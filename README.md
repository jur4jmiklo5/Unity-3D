# Unity-3D

Unity project focused on interactive 3D environment design, gameplay scripting.

## Demo video

https://drive.google.com/file/d/1ynZRimQpbfrp47z82RUtphxk7UWx2YKW/view?usp=sharing

## Project Highlights

- Built with Unity `2019.4.14f1` (LTS)
- Third-person movement using the Unity Input System
- Click-based in-scene interactions and trigger-driven behavior
- Dinosaur ride mechanic (mount, follow/sync, dismount)
- Dynamic fog controller based on player distance
- Modular C# gameplay scripts organized by feature responsibility

## Core Features

1. **Player Movement**
   - Keyboard/gamepad movement through generated Input Actions (`PlayerControl`)
   - Character rotation and directional movement via `CharacterController`

2. **Interactive Objects**
   - Clickable objects that toggle visibility, information panels, and audio
   - Utility behaviors such as billboard-facing, rotation, and material/color changes

3. **Dinosaur Ride System**
   - Raycast-based mount interaction
   - Avatar-to-dinosaur synchronization while riding
   - Controlled dismount sequence and animator switching

4. **Environment & Atmosphere**
   - Distance-based dynamic fog (`RenderSettings.fogDensity`)
   - Scene assets for sky, vegetation, and stylized world dressing

## Controls

- `W / S` - move forward/backward
- `A / D` - rotate character
- `LMB` - interact (e.g., click dinosaur or interactive objects)
- `G` - dismount while in ride mode

## Getting Started

1. Open the project in **Unity Hub**.
2. Use Unity Editor version `2019.4.14f1`.
3. Open `Assets/Scenes/SampleScene.unity`.
4. Press `Play`.
