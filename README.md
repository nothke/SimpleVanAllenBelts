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
Each belt is composed of 2 toruses (tori?). The resulting value is first torus minus second torus (like relative complement in sets: A ∖ B). r1 is the major radius, while r2 is the minor radius. stretch is how elliptical the torus tube (r2) will be. in_ values are values for the second torus. To preview it, you can drop your Toroidal Belt Data asset into the previewer in preview scene.

To sample a value from it, use myToroidalBeltData.Sample(yourPosition).
