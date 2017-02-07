name SetTest;


type(9) AbstractThing {
	int intValue1;
}

type(10) Thing1 : AbstractThing {
	int intValue2;
}

type(11) Thing2 : AbstractThing {
	int intValue3;
}

type(12) IntSetObject {
	set<int> intSetValue;
}

type(13) StringSetObject {
	set<string> stringSetValue;
}


type(14) Thing1SetObject {
	set<Thing1> thingSetValue;
}

type(15) AbstractThingSetObject {
	set<AbstractThing> abstractThingSetValue;
}

type(16) VIntSetObject {
	set<vint> vintSetValue;
}
