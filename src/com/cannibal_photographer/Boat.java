package com.cannibal_photographer;


import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;

public class Boat extends ImageView {
	
	//ImageView boatimage = (ImageView)findViewById(R.id.imageView1);
	
	int state = 0;
	
	public Boat(Context context, AttributeSet attrs, ImageView boatimage) {
        super(context, attrs);
        
    }
   

	public void moveBoatForward(final ImageView boatimage){
	
		boatimage.setOnClickListener(new OnClickListener() {
		
			@Override
			public void onClick(View v) {

				
				boatimage.offsetTopAndBottom(-290);
				
				/*
				
				TranslateAnimation animation = new TranslateAnimation(0, 0, 0, -290);
				animation.setDuration(250);
				animation.setFillEnabled(true);
				animation.setFillAfter(true);
				boatimage.startAnimation(animation);
				
				boatimage.setVisibility(View.INVISIBLE);
				boatimage2.setVisibility(View.VISIBLE);
				*/
			    	
			}
	
		});

	}
	
	public void moveBoatReverse(final ImageView boatimage){
		
		boatimage.setOnClickListener(new OnClickListener() {
		
			@Override
			public void onClick(View v) {
				
				
				
				
					boatimage.offsetTopAndBottom(290);
				
				/*
				TranslateAnimation animation = new TranslateAnimation(0, 0, 0, 290);
				animation.setDuration(250);
				animation.setFillEnabled(true);
				animation.setFillAfter(true);
				boatimage2.startAnimation(animation);
				
				boatimage.setVisibility(View.VISIBLE);
				boatimage2.setVisibility(View.INVISIBLE);
				*/
			    	
			}
	
		});

	}

}


