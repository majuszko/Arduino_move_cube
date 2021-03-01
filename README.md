# Arduino_move_cube
Test of Arduino and Unity using Ardity, which allows bidirectional communication over COM ports from Unity. Ardity is available for free in the Asset store.

The main idea of this experiment was to check how would Arduino work as a device to move a cube in the Unity scene.

Used components:
- Arduino Nano
- Ultrasound sensor
- Ardity

The ultrasound sensor was used to measure the distance to the nearest obstacle and depending on the measurement, the cube moved faster or slower (when the distance was smaller, the cube moved 
slower, and it moved faster when the distance was bigger).
