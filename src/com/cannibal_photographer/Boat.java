package com.cannibal_photographer;


import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.view.animation.TranslateAnimation;
import android.widget.ImageView;

public class Boat extends ImageView {
	
	//ImageView boatimage = (ImageView)findViewById(R.id.imageView1);
	
	
	
	public Boat(Context context, AttributeSet attrs) {
        super(context, attrs);
        
    }
   

	public void moveBoatForward(final ImageView boatimage){
	
		boatimage.setOnClickListener(new OnClickListener() {
		
			@Override
			public void onClick(View v) {
				
				TranslateAnimation animation = new TranslateAnimation(0, 0, 0, -290);
				animation.setDuration(250);
				animation.setFillAfter(true);
				boatimage.startAnimation(animation);
			    	
			}
	
		});

	}

}


