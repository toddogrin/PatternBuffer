name MapTest;

enum MyEnum {
    value1,
	value2,
	value3
}

type() AbstractThing {
	bool isSomething;
}

type(10) Thing : AbstractThing {
	int intValue;
}

type(11) IntThingMapObject {
	map<int,Thing> intThingMap;
}

type(12) ThingIntMapObject {
	map<Thing,int> thingIntMap;
}

type(13) IntStringMapObject {
	map<int,string> intStringMap;
}

type(14) ThingThingMapObject {
	map<Thing,Thing> thingThingMap;
}

type(15) EnumIntMapObject {
	map<MyEnum,int> enumIntMap;
}

type(16) VIntVLongMapObject {
	map<vint,vlong> vintVlongMap;
}

type(17) IntAbstractThingMapObject {
	map<int, AbstractThing> intAbstractThingMap;
}