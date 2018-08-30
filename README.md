# SimpleVanAllenBelts
SDF based Van Allen belt sampler, implemented in C# (Unity)

A crude approximation of [Van Allen radiation belts](https://en.wikipedia.org/wiki/Van_Allen_radiation_belt) made by adding and subtracting toroidal belt SDFs. Made to run fast and consistently and is NOT supposed to be scientifically precise. To be primarily used for entertainment.

Because it is [signed distance function](https://en.wikipedia.org/wiki/Signed_distance_function) based, it doesn't suffer from undersampling as a voxel-data based solution would. The data is just a few scalar parameters. On the other hand it doesn't simulate changes of shape [yet], or local deviations.

It is single precision based, but can be easily upgraded to double precision (there's very little code actually).

<p align="center">
<img src="https://github.com/nothke/SimpleVanAllenBelts/blob/master/doc/Unity_2018-08-30_19-58-43.png" width="500">
</p>

A "poor man's" voxel previewer using gizmos is included (the data is not pointy, the function is smooth, it's the previewer that's pointy).

And an example of Earth's belts is included too. It is not based on any hard data, [just approximated off a, not very prcise, plot](https://github.com/nothke/SimpleVanAllenBelts/blob/master/doc/Unity_2018-08-30_19-55-38.png?raw=true) (scaled by a factor of 1,000,000)

<p align="center">
<img src="https://github.com/nothke/SimpleVanAllenBelts/blob/master/doc/slice2.gif" width="500">
</p>

### But why?
I needed it for a thing where a spacecraft passing through radiation belts would be damaged, this is the solution I came up with.

### How to create belts and use it
To Create a new ToroidalBelt, right click in project window > Orbital > Toroidal Belt Data.
Each belt is composed of 2 toruses (tori?). The resulting value is first torus minus second torus (like relative complement in sets: A ∖ B). r1 is the major radius, while r2 is the minor radius. stretch is how elliptical the torus tube (r2) will be. in_ values are values for the second torus. To preview it, you can drop your Toroidal Belt Data asset into the previewer in preview scene.

To sample a value from it, use myToroidalBeltData.Sample(yourPosition).
