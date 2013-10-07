package com.cannibal_photographer;



import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.view.animation.TranslateAnimation;
import android.widget.ImageView;

public class Boat extends ImageView {
	
	boolean state = true;
	
	public Boat(Context context) {
        super(context);
        init();
	}
	
	 public Boat(Context context, AttributeSet attrs)
	    {
	        super(context, attrs);
	        init();
	    }

	 public Boat(Context context, AttributeSet attrs, int defStyle)
	    {
	        super(context, attrs, defStyle);
	        init();
	    }

    private void init()
    {
        this.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick (View v) {
                if (state) {
				    moveBoat(-290);
                } else {
                    moveBoat(290);
                }
			}
        });
    }
    
    //TranslateAnimation animation;
    //TranslateAnimation animation2;

	public void moveBoat(int amount){
		/*
		animation = new TranslateAnimation(0, 0, 0, amount);
		animation.setDuration(250);
		animation.setFillAfter(true);
		this.startAnimation(animation);
		*/
        this.offsetTopAndBottom(amount);
        state = !state;
	}
}



