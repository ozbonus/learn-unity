using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	// up -> breakfast -> clean -> dressed -> bus -> store -> work
	public Text text;
	public enum States {
		bed,
		up,
		breakfast,
		clean,
		dressed,
		bus,
		store,
		work,
		breakfast_fail,
		clean_fail,
		dressed_fail,
		bus_fail,
		store_fail,
		work_fail
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.bed;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.bed) {bed ();}
		else if (myState == States.up) {up ();}
		else if (myState == States.breakfast) {breakfast ();}
		else if (myState == States.clean) {clean ();}
		else if (myState == States.dressed) {dressed ();}
		else if (myState == States.bus) {bus ();}
		else if (myState == States.store) {store ();}
		else if (myState == States.work) {work ();}
		else if (myState == States.breakfast_fail) {breakfast_fail ();}
		else if (myState == States.clean_fail) {clean_fail ();}
		else if (myState == States.dressed_fail) {dressed_fail ();}
		else if (myState == States.bus_fail) {bus_fail ();}
		else if (myState == States.store_fail) {store_fail ();}
	}

	void bed () {
		text.text = "Another dreary day has begun.\n\n" +
					"1 Get out of bed.\n" +
					"2 Eat breakfast.\n" +
					"3 Get dressed.\n" +
					"4 Get cleaned up.\n" +
					"5 Catch the bus.";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.up;}
		if (Input.GetKeyDown(KeyCode.Alpha2)) {myState = States.breakfast_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha3)) {myState = States.dressed_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha4)) {myState = States.clean_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha5)) {myState = States.bus_fail;}
	}

	void up () {
		text.text = "Stretch. Pet the cat. Now what?\n\n" +
					"1 Eat breakfast.\n" +
					"2 Get dressed.\n" +
					"3 Catch the bus.\n" +
					"4 Go to the convenience store.\n" +
					"5 Get cleaned up.";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.breakfast;}
		if (Input.GetKeyDown(KeyCode.Alpha2)) {myState = States.dressed_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha3)) {myState = States.bus_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha4)) {myState = States.store_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha5)) {myState = States.clean_fail;}
	}

	void breakfast () {
		text.text = "It tastes like cardboard.\n\n" +
					"1 Catch the bus.\n" +
					"2 Get cleaned up.\n" +
					"3 Get dressed.\n" +
					"4 Go to the convenience store.";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.bus_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha2)) {myState = States.clean;}
		if (Input.GetKeyDown(KeyCode.Alpha3)) {myState = States.dressed_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha4)) {myState = States.store_fail;}
	}

	void clean () {
		text.text = "Showered, shaved, running late.\n\n" +
					"1 Catch the bus.\n" +
					"2 Get dressed.\n" +
					"3 Go to the convenience store.";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.bus_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha2)) {myState = States.dressed;}
		if (Input.GetKeyDown(KeyCode.Alpha3)) {myState = States.store_fail;}
	}

	void dressed () {
		text.text = "When were these last washed?\n\n" +
					"1 Go to the convenience store.\n" +
					"2 Catch the bus.";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.store_fail;}
		if (Input.GetKeyDown(KeyCode.Alpha2)) {myState = States.bus;}
	}

	void bus () {
		text.text = "Twenty minutes of reading time. Or maybe Reddit.\n\n" +
					"1 Swing by the convenience store.";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.store;}
	}

	void store () {
		text.text = "Sugar-free green tea and over-sweetened bread.\n\n" +
					"1 Trudge into work.";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.work;}
	}

	void work () {
		text.text = "Fantasize about a better job.\n\n" +
					"Stare into [SPACE] until tomorrow.";
		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.bed;}
	}

	void breakfast_fail () {
		text.text = "You spent too long enjoying your coffee.\n\n" +
					"Press [SPACE] to live another day.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.bed;}
	}

	void clean_fail () {
		text.text = "The warm shower water was just too comfortable. You were late to work.\n\n" +
					"Press [SPACE] to live another day.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.bed;}
	}

	void dressed_fail () {
		text.text = "You couldn't decide which belt to wear and were late to work.\n\n" +
					"Press [SPACE] to live another day.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.bed;}
	}

	void bus_fail () {
		text.text = "You get to work but are unprepared to do your job.\n\n" +
					"Press [SPACE] to live another day.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.bed;}
	}

	void store_fail () {
		text.text = "Going to the store now has caused you to miss the bus, making you late for work.\n\n" +
					"Press [SPACE] to live another day.";
		if (Input.GetKeyDown(KeyCode.Space)) {myState = States.bed;}
	}
}
