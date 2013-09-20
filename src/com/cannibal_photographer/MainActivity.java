package com.cannibal_photographer;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.widget.ImageView;



public class MainActivity extends Activity {
	
	
	//OnClickListener boatForwardListener;
	
	
	

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		ImageView boatimage = (ImageView)findViewById(R.id.imageView1);
		
		Boat boatobject = new Boat(this, null);
		
		boatobject.moveBoatForward(boatimage); 
		
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}


}
