## Font 3D
This package provides a shader and accompanying scripts that make it easy to prevent text from rendering through walls.

### Usage
Place a normal `3D Text` component into your scene, then add a `Font 3D` component to the object. This will automatically make all needed material and shader changes, and keep these up to date whenever you change the font or color of your text.

If you need to change your text's color at runtime, be sure to change the object's `Material` color, not it's `TextMesh` color.
