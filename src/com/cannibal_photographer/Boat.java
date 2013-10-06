package com.cannibal_photographer;



import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;

public class Boat extends ImageView {
	
	ImageView boatimage;
	boolean state = true;
	
	public Boat(Context context, AttributeSet attrs, ImageView boatimage) {
        super(context, attrs);
        boatimage = (ImageView)findViewById(R.id.imageView1);
        boatimage.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick (View v) {
                if (state) {
				    moveBoatForward(-290);
                } else {
                    moveBoatReverse(290);
                }
			}
        });
    }
   

	public void moveBoatForward(int amount){
        boatimage.offsetTopAndBottom(amount);
        state = !state;
	}
	
    public void moveBoatReverse(int amount) {
        boatimage.offsetTopAndBottom(290);
        state = !state;
	}

}



