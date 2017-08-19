name EnumTest;

enum SomeEnum {
	value1,
	value2,
	value3
}

enum SomeEnum2 {
	value4,
	value5,
	value6
}


type(11) EnumObject {
	SomeEnum someEnumValue;
}


type(12) EnumListObject {
	list<SomeEnum> someEnumListValue;
}


type(13) EnumMapObject {
	map<int,SomeEnum> intSomeEnumMapValue;
}

type(14) EnumMap2Object {
	map<SomeEnum,int> someEnumIntMapValue;
}

type(15) EnumSetObject {
	set<SomeEnum> someEnumSetValue;
}

/*
enum SomePathedEnum {
	[pb.path="Path1/Path2"]
	value1,
	value2,
	value3
}
*/