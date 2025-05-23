public interface LongRest {
	/*
	 * This interface acts as the subject in the observer pattern notifying observers
	 * depending on if the observers are awake (on watch) or asleep.
	 */

	public void stayAwake(OnWatch watcher);
	public void goToSleep(OnWatch watcher);
	public void somethingHappened();	
}