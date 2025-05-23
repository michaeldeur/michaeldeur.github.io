public class Knight extends Character {
	/*
	 * This is the class created for the knight to determine the response depending on whether
	 * the knight is sleeping or something is happening 
	 */

	// Creates a default attitude if nothing is happening
	private final String DEFAULT_ATTITUDE;

	/*
	 * Constructor that passes in a LongRest object to the parent through the super.
	 * Sets the attitude to the default of nothing happening and staying awake.
	 */
	public Knight(LongRest night) {
		super(night);
		this.attitude = DEFAULT_ATTITUDE = "Enjoying some quiet time polishing my sword.";
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
	@Override
	public void observeEncounter(Encounter encounter) {
		switch (encounter) {
            case Squirrel:
                attitude = "I hope the squirrel doesn't encounter an owl.";
                break;
			case Goblin:
				attitude = "I bet I could scare the goblin away with a creepy noise.";
				break;
			case Troll:
				attitude = "Now it's time to prove my mettle on this troll.";
				break;
			case Dragon:
				attitude = "I don't like this dragon... I've been burnt before!";
				break;
            default:
                attitude = DEFAULT_ATTITUDE;
                break;
        }
	}

	// Displays a String describing the character.
	public String toString() {
		return "Knight in Shining Armor";
	}
}