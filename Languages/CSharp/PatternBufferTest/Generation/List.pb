name ListTest;

type(9) AbstractThing {
	int intValue1;
}

type(10) Thing1 : AbstractThing {
	int intValue2;
}

type(11) Thing2 : AbstractThing {
	int intValue3;
}

type(12) IntListObject {
	list<int> intListValue;
}

type(13) StringListObject {
	list<string> stringListValue;
}

type(14) Thing1ListObject {
	list<Thing1> thingListValue;
}

type(15) AbstractThingListObject {
	list<AbstractThing> abstractThingListValue;
}

type(16) VIntListObject {
	list<vint> vintListValue;
}
