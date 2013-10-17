package com.cannibal_photographer;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.RelativeLayout;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);	
		Boat boatobject = (Boat)findViewById(R.id.boatimageView);	
		Person personobject = (Person)findViewById(R.id.personView1);
		RelativeLayout main = (RelativeLayout)findViewById(R.layout.activity_main);
		View personview = getLayoutInflater().inflate(R.layout.personlayout,  main, false);
        View boatview = getLayoutInflater().inflate(R.layout.boatlayout, main,false);
        main.addView(boatview);
        main.addView(personview);
	}
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
}
