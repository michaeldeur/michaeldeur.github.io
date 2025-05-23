public class Wizard extends Character {
	/*
	 * This is the class created for the wizard to determine the response depending on whether
	 * the wizard is sleeping or something is happening 
	 */

	// Creates a default attitude if nothing is happening
	private final String DEFAULT_ATTITUDE;

	/*
	 * Constructor that passes in a LongRest object to the parent through the super.
	 * Sets the attitude to the default of nothing happening and staying awake.
	 */
	public Wizard(LongRest night) {
		super(night);
		this.attitude = DEFAULT_ATTITUDE = "Reading my spell book.";
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
	@Override
	public void observeEncounter(Encounter encounter) {
		switch (encounter) {
            case Squirrel:
                attitude = "I hope the squirrel doesn't encounter an owl.";
                break;
			case Goblin:
				attitude = "I hope that goblin doesn't see me.";
				break;
			case Troll:
				attitude = "Oh no, a troll! I wish I had prepared my fireball spell!";
				break;
			case Dragon:
				attitude = "See ya, I'm outta here!";
				break;
            default:
                attitude = DEFAULT_ATTITUDE;
                break;
        }
	}

	// Displays a String describing the character.
	public String toString() {
		return "Mysterious, Arcane Wizard";
	}
}