public class Barbarian extends Character {
	/*
	 * This is the class created for the barbarian to determine the response depending on whether
	 * the barbarian is sleeping or something is happening 
	 */

	// Creates a default attitude if nothing is happening
	private final String DEFAULT_ATTITUDE;

	/*
	 * Constructor that passes in a LongRest object to the parent through the super.
	 * Sets the attitude to the default of nothing happening and staying awake.
	 */
	public Barbarian(LongRest night) {
		super(night);
		this.attitude = DEFAULT_ATTITUDE = "Staring into the fire... feeling hungry.";
		night.stayAwake(this);
	}

	/*
	 * Displays the current attitude of the character based on if the they are sleeping or
	 * their response to something happening.
	 */
	public void display() {
        System.out.println(attitude);
	}

	/*
	 * A switch statements that checks which of the items matches the encounter object.
	 * The default is Nothing from the enum Encounter.
	 */
	public void observeEncounter(Encounter encounter) {
		switch (encounter) {
            case Squirrel:
                attitude = "Squirrel would make a good snack.";
                break;
			case Goblin:
				attitude = "I could slice that goblin in two with one blow.";
				break;
			case Troll:
				attitude = "Bet I could dice up troll faster than it regenerates.";
				break;
			case Dragon:
				attitude = "Wonder how bad the dragon's fire hurts!";
				break;
            default:
                attitude = DEFAULT_ATTITUDE;
                break;
        }
	}

	// Displays a String describing the character.
	public String toString() {
		return "Fur-clad Raging Barbarian";
	}
}