name NullableTest;

type(7) Thing {
	int value;
}

type(8) ThingContainer {
	Thing thing1;
	Thing thing2;
	Thing thing3;
	Thing thing4;
	Thing thing5;
	int intValue1;
	Thing thing6;
	Thing thing7;
	Thing thing8;
	Thing thing9;
	int intValue2;
	Thing thing10;
}

type() AbstractThingContainer1 {
	Thing thing1;
}
type() AbstractThingContainer2 : AbstractThingContainer1 {
	Thing thing2;
}
type(9) ThingContainer3 : AbstractThingContainer2 {
	Thing thing3;
}


type() BaseType {
	bool booleanValue;
}
type(10) DerivedType1 : BaseType {
	long longValue;
}
type(11) DerivedType2 : BaseType {
	byte byteValue;
}
type (12) BaseTypeContainer {
	BaseType value1;
	BaseType value2;
}

type(13) ListContainer {
	list<int> intList;
}

type(14) SetContainer {
	set<int> intSet;
}

type(15) MapContainer {
	map<int,short> intShortMap;
}

type(16) IntThingContainerMap {
	map<int,ThingContainer> theMap;
}

type(#) AutogenerateTest {
	int value;
}