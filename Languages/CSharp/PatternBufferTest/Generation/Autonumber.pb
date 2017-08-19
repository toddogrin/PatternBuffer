name AutonumberTest;

type(1) ShouldBe1 {
	int value;
}

type(#) ShouldBe2 {
	int value;
}

type(#) ShouldBe3 {
	int value;
}

type() AbstractThingShouldBe0 {
	bool dunno1;
}

type(17) BaseThingShouldBe17 : AbstractThingShouldBe0 {
	bool dunno2;
}

type(#) ShouldBe4 : BaseThingShouldBe17 {
	bool dunno3;
}

type(#) BaseThingShouldBe5 : AbstractThingShouldBe0 {
	bool dunno4;
}

type(57) ShouldBe57 : BaseThingShouldBe5 {
	bool dunno5;
}

type(#) NewAbstractShouldBe6 {
	bool dunno6;
}

type(#) NewAbstractShouldBe7 {
	bool dunno7;
}

type(#) NewAbstractShouldBe8 {
	bool dunno8;
}

type(566) ShouldBe566 {
	bool dunno566;
}