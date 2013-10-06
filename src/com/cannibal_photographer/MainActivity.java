package com.cannibal_photographer;

import android.app.Activity;
import android.graphics.Rect;
import android.os.Bundle;
import android.view.Menu;
import android.widget.ImageView;
import android.widget.TextView;



public class MainActivity extends Activity {
	
	int state = 0;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		ImageView boatimage = (ImageView)findViewById(R.id.imageView1);
		Rect r = boatimage.getDrawable().getBounds();

		int drawLeft = r.left;
		int drawTop = r.top;
		int drawRight = r.right;
		int drawBottom = r.bottom;
		//ImageView boatimage2 = (ImageView)findViewById(R.id.imageView2);
		
		Boat boatobject = new Boat(this, null);
		
		int y = boatimage.getBottom();
		
		TextView textView = (TextView) findViewById(R.id.textView1);
		textView.setText(String.valueOf(drawBottom));
		//.makeText(this, y, Toast.LENGTH_LONG).show();
		//toast.setView(boatobject);
		// Toast...
		
		
		//int y = boatobject.getTop();
		//display in long period of time
		//Toast.makeText(getApplicationContext(), y, Toast.LENGTH_LONG).show();
		//Toast toast = Toast.makeText(this, y, 2000);
		//toast.show();
	
		
		/*
		if (state == 0)
		{
			boatobject.moveBoatForward(boatimage);
			state=1;
		}
		
		else if(state == 1)
		{
			boatobject.moveBoatReverse(boatimage);
			state=0;
		}
		*/
		
		switch ( state ) {
			case 0: 
				boatobject.moveBoatForward(boatimage);
				state=1;
				break;
			case 1: 
				boatobject.moveBoatReverse(boatimage);
				state=0;
				break;
			default:
				break;

		}
			
	}
		
		//boatobject.moveBoatForward(boatimage);
		//boatobject.moveBoatReverse(boatimage);
		

	

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}


}
