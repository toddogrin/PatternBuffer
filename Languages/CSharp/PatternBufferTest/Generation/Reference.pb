name ReferenceTest;

type(11) Thing {
	int intValue;
}

type(12) FinalObject {
	Thing thingValue;
}

type() AbstractThing {
	int intValue1;
}

type(22) FinalThing1 : AbstractThing {
	int intValue2a;
}

type(23) FinalThing2 : AbstractThing {
	int intValue2a;
}

type(24) AbstractReferenceObject {
	AbstractThing thing;
}