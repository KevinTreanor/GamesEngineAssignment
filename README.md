# GamesEngineAssignment

# Journey: a nature music inspired visualiser using unity

## Overview:
The plan for this assignment is to match the serenity of the music playing with a natural environment. The camera will follow a track from a lake at the beginning through a forrest. As the tempo of the music increases the camera will gradually climb though the forrest.

## Technical plan:
I plan on procedurally generating the forrest around the player. All of the bodies of the trees will integrated with audio visulisation to match the frequency of the music. For examples more relaxed melodies will result in more round shapes where as sharper beats will result in jagged and sharp tree bodies. I also plan on matching the trees sway to the rhytm of the music.

## Inspiration:
The inspirtaion of this project came from multiple sources. The first source is based off of video games.Two of the games that had the most impact on me are "Journey" and "Spirit in the North". These games are based on taking the user through beautiful environments accompanied with relaxing melodies.

The second source of inspiration comes from a simple walk in the woods. Generally walking in the woods is considered a transient escape from the bustle of everyday life and my aim is to take that pocket of serenity and digitalise it. I want to fully immerse the user to achieve that same escape from reality.

My final source of inspiration came from the many audio visualisers that I watched on youtube. The manipulation on objects were a prime example of what I want to achieve with my trees.

## Brief:
The assignment land scape is generated naturally from a procedural generation script. This landscape is also poulated with custom made Tree and Grass Prefabs. These Prefabs have aduio visualisers attached to certain parts of their game objects which vary the X and Z components of their Vector3's. These Prefabs also are set to change to a random RGB color based on a timer. The project is experienced through the view of several cameras spread throughout the generated landscape which is itereated through *using the space key*. There is a shader on the landscape as well as a fog set up witihin the scene to ehance the aesthetic. The song used for this visualizer is Somewhere I'd Rather Be by Wisp X.

## Development
Compenents of the Shader, Audio Visualizer and Terrain generation were adapted from lecture code. The prefabs and all other containing scrpits, environments and resources were created from scratch.

## Highlights:
I am most proud of the aesthetic side of this project. In essense, this was adapting the audio visualizer code alongside the RGB aspect of the prefabs to enhance the visual experience as well as setting up the best camera positions to enjoy the experince. I feel the theme oif Nature was the prime inspiration for this project and is reflected through out.

## Instructions
Space bar is the key for iterating through the Camera positions

## Video Demo:

[![YouTube](http://img.youtube.com/vi/2TF44_jPrPg/0.jpg)](https://www.youtube.com/watch?v=2TF44_jPrPg)



## References:
Journey: https://www.youtube.com/watch?v=mU3nNT4rcFg <br />
Spirit in the North: https://www.youtube.com/watch?v=YN5DTaYdiLw <br />
Procedural generation tutorial: https://gamedevacademy.org/complete-guide-to-procedural-level-generation-in-unity-part-3/ <br />
Procedural generation example: https://www.youtube.com/watch?v=YEGodGO-o9M <br />
Audio Visualiser: https://www.youtube.com/watch?v=82Q6DRqf9H4 <br />
Mesh Modifier: https://www.youtube.com/watch?time_continue=10&v=Vft7kD6HQnA <br />
Song: https://www.youtube.com/watch?v=V5-AQTPFJSg <br />

