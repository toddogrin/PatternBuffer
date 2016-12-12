# PatternBuffer #

Energizing object serialization across languages and platforms!

## Purpose ##

The main goal of PatternBuffers is to make object serialization and deserialization as easy as this:

```
// Serialize a thing
byte[] bytes = myPatternBuffer.Energize(thing1);

// Deserialize a thing
Thing thing2 = (Thing)myPatternBuffer.Energize(bytes);
```

## Use Cases ##

What are PatternBuffers good for? Like, a lot!

* Sending and receiving real-time game data over a network socket
* Reading or writing save games to/from local device storage
* Reading and writing structured static metadata (don't use JSON, ew)
* Minimizing the footprint of objects stored in memory or persistent storage
* And more!

## How to Use PatternBuffers ##

Here is how to use PatternBuffers, in a nutshell:

1. **Define!** -- Describe your objects in the PatternBuffer schema language.

2. **Generate!** -- Use a PatternBuffer compiler to generate all the serialization code for the objects defined in your schema.

3. **Energize!** -- Issue one method call to serialize or deserialize your data quickly (it's fast) and economically (it's small).

4. **Customize!** -- Not happy with the generated code? Branch and change the compiler code to suit your needs, in the language you are comfortable with.

## PatternBuffer Features ##

More specifically, PatternBuffer offers these features:

* A schema language for defining your objects
* 16 primitive types, in addition to lists, sets, maps, and enums
* Strict typing to ensure clarity, and to integrate with IDE code completion features
* Object inheritance and polymorphism for maximum expressiveness
* Optional compact primitives to minimize impact on resources like memory, disk space, bandwidth
* Extremely efficient serialization code; does not use reflection
* Modestly sized binaries
* Compilers written in a variety of languages
* Compiler hints to help customize compiler output

## Building ##

PatternBuffers are implemented across different languages and platforms. This means there are as many build processes as target languages. See the README for each specific language in the Languages source folder.

## Usage ##

For information on how to use PatternBuffers, see the [PatternBuffer Documentation Wiki](https://github.com/toddogrin/PatternBuffer/wiki) Wiki page.

## Contributions ##

Feel free to fork and PR your changes for review. Useful enhancements accepted as long as they come with unit tests, comments, and clean code.

## Contact ##

The PatternBuffer repository was written and is maintained by Todd Ogrin (<toddogrin@gmail.com>).
