public class Ranger extends Character {
	/*
	 * This is the class created for the ranger to determine the response depending on whether
	 * the ranger is sleeping or something is happening 
	 */

	// Creates a default attitude if nothing is happening
	private final String DEFAULT_ATTITUDE;

	/*
	 * Constructor that passes in a LongRest object to the parent through the super.
	 * Sets the attitude to the default of nothing happening and staying awake.
	 */
	public Ranger(LongRest night) {
		super(night);
		this.attitude = DEFAULT_ATTITUDE = "The stars are beautiful.";
		night.stayAwake(this);
	}
	
	/*
	 * Displays the current attitude of the character based on if the they are sleeping or
	 * their response to something happening.
	 */
	@Override
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
                attitude = "The simple life of a squirrel is marvelous.";
                break;
			case Goblin:
				attitude = "Goblins are such a distortion of nature.";
				break;
			case Troll:
				attitude = "I hate trolls! Time to light up my arrows.";
				break;
			case Dragon:
				attitude = "My arrows cannot penetrate the dragon scales!";
				break;
            default:
                attitude = DEFAULT_ATTITUDE;
                break;
        }
	}

	// Displays a String describing the character.
	public String toString() {
		return "Quick, Stealthy Ranger";
	}

}