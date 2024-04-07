# Unity_PathHighlighter_Utility
A simple Utility to trace the path of an object in Unity scene and game view using instanced meshes.

**Demo** <br />
![Demo](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExcTBpeTliaGNqNTYxaWt3b3BpMDJ2ZHJ5YXoydW5zbWZ4NjRtOGd2eCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/DCyw9nbjVvfB4dVo71/giphy.gif)
<br /> Tracing a child object of the camera to trace the camera path.

**Tool Settings** <br />
![Tool Settings](https://i.gyazo.com/c1c9a15b2b3391ad5d4db0233c21acf0.png)

## Instructions
1. Add script to Object you want trace path
2. Select Mesh you want to use as Marker tip (Sphere used in demo)
3. Make a new material for Marker tip
4. Set Material Rendering mode to Transparent and Enable GPU Instancing
5. Choose Highlight color in Tool Settings (changes Marker Tip Material Albedo)
6. Adjust settings as needed
