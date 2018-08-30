# SimpleVanAllenBelts
SDF based Van Allen belt sampler, implemented in C# (Unity)

A crude approximation of Van Allen belts made by adding and subtracting toroidal belt SDFs. Made to run fast and is NOT supposed to be scientifically precise. To be primarily used for entertainment.

<p align="center">
<img src="https://github.com/nothke/SimpleVanAllenBelts/blob/master/doc/Unity_2018-08-30_19-58-43.png" width="500">
</p>

A "poor man's" voxel previewer using gizmos, and a sample of Earth's belts is included, not based on any hard data, [just approximated off a plot](https://github.com/nothke/SimpleVanAllenBelts/blob/master/doc/Unity_2018-08-30_19-55-38.png?raw=true) (scalled by a factor of 1,000,000)

<p align="center">
<img src="https://github.com/nothke/SimpleVanAllenBelts/blob/master/doc/slice2.gif" width="500">
</p>

### But why?
I needed it for a thing where a spacecraft passing through radiation belts would be damaged, this is the solution I came up with.

### How to create belts and use it
To Create a new ToroidalBelt, right click in project window > Orbital > Toroidal Belt Data.

To sample it, use myToroidalBeltData.Sample(yourPosition).
