public abstract class Character implements OnWatch, DisplayAttitude {
	/*
	 * Abstract class that implements two interfaces and serves as an inheritance parent
	 * for the characters.
	 */
	
	// Declares a String for direct use by children and a private LongRest object.
    protected String attitude;
	private LongRest rest;

	// Constructor that takes in a LongRest object and assigns it to the one created in the class.
	public Character(LongRest rest) {
		this.rest = rest;
	}

	// Assigns a response for the characters if they are sleeping and calls to change to sleep.
	public void goToSleep() {
		rest.goToSleep(this);
		attitude = "Sleeping the night away.";
	}

	// Calls to change character to awake.
	public void stayAwakeForWatch() {
		rest.stayAwake(this);
	}
}