import java.util.ArrayList;

public class NightInTheWilderness implements LongRest {
	/*
	 * Class that implements LongRest interface and sets subscription,
	 * unsubscrption, and notification to changes.
	 */

	// Creates a private arraylist and an Encounter object.
	private ArrayList<OnWatch> observers;
    private Encounter currentEncounter;

	/*
	 * Constructor that initializes an new arraylist of OnWatch objects and
	 * sets the currentEncounter to nothing from the enum named Encounter.
	 */
	public NightInTheWilderness() {
		this.observers = new ArrayList<OnWatch>();
        this.currentEncounter = Encounter.Nothing;
	}

	/*
	 * Sets the encounter to equal the new encounter and update characters unless
	 * it is the same encounter.
	 */
	public void setEncounter(Encounter encounter) {
		if (encounter != currentEncounter) {
            this.currentEncounter = encounter;
            somethingHappened();
        }
	}

	// Subscribes characters if they are not already on watch to be on watch instead of sleeping.
	@Override
	public void stayAwake(OnWatch watcher) {
		if (!observers.contains(watcher)) {
            this.observers.add(watcher);
        }
	}

	// Allows for characters to unsubscribe from watch duty so they can sleep.
	@Override
	public void goToSleep(OnWatch watcher) {
		if (observers.contains(watcher)) {
            this.observers.remove(watcher);
        }
	}

	/*
	 * Updates all the characters subscribed to being on watch of what is happening.
	 */ 
	@Override
	public void somethingHappened() {
		for (OnWatch observer : observers) {
            observer.observeEncounter(currentEncounter);
        }
	}
	
}