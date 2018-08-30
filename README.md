# SimpleVanAllenBelts
SDF based Van Allen belt sampler, implemented in C# (Unity)

A crude approximation of Van Allen belts made by adding and subtracting toroidal belt SDFs. Made to run fast and is NOT scientifically correct. Not based on hard data, just approximated from a plot. To be primarily used for entertainment.

![alt text](https://github.com/nothke/SimpleVanAllenBelts/blob/master/doc/Unity_2018-08-30_19-58-43.png?raw=true "Preview")

A "poor man's" voxel previewer using gizmos, and a sample of Earth's belts is included.

![alt text](https://github.com/nothke/SimpleVanAllenBelts/blob/master/doc/slice2.gif?raw=true "Preview")

### But why?
I needed it for a game where a spacecraft passing through radiation belts would be damaged, this is the solution I came up with.

### How to create belts and use it
To Create a new ToroidalBelt, right click in project window > Orbital > Toroidal Belt Data.

To sample it, use myToroidalBeltData.Sample(yourPosition).
