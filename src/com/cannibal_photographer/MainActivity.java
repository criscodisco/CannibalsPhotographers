package com.cannibal_photographer;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.view.animation.TranslateAnimation;
import android.widget.ImageView;



public class MainActivity extends Activity implements ImageView.OnClickListener{
	
	ImageView boatimage;
	

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		boatimage = (ImageView) findViewById(R.id.imageView1);
        boatimage.setOnClickListener(this);
		
		/*
		RelativeLayout rootLayout = (RelativeLayout) findViewById(R.layout.activity_main);
        RelativeLayout.LayoutParams params = new RelativeLayout.LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT);
        rootLayout.setLayoutParams(params);

        
        RelativeLayout.LayoutParams paramsImage = new RelativeLayout.LayoutParams(LayoutParams.WRAP_CONTENT, LayoutParams.WRAP_CONTENT);
        paramsImage.addRule(RelativeLayout.CENTER_IN_PARENT);
        boatimage.setLayoutParams(paramsImage);
		*/
		
		//final ImageView boatimage = new ImageView(this);;
		
        //boatimage = (ImageView)findViewById(R.id.imageView1);
        //boatimage.setImageResource(R.drawable.boat);
        //rootLayout.addView(boatimage);

        
		
		
		
		/*
		final TranslateAnimation animation = new TranslateAnimation(0, 50, 0, 100);
		animation.setDuration(5000);
		animation.setFillAfter(true);
		animation.setAnimationListener(new MyAnimationListener());
		
		
		boatimage.setOnClickListener(new View.OnClickListener() {

	        @Override
	        public void onClick(View view) {
	        	if (view == findViewById(R.id.imageView1)){
	        		boatimage.startAnimation(animation);
	        	}
	        }
	    });
		
		*/
		
		
		
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	@Override
	public void onClick(View v) {
		
		TranslateAnimation animation = new TranslateAnimation(0, 0, 0, -290);
		animation.setDuration(250);
		animation.setFillAfter(true);
		boatimage.startAnimation(animation);
	    	
	}
	
	/*
	public class MyAnimationListener implements AnimationListener{
		
		

	    @Override
	    public void onAnimationEnd(Animation animation) {
	        boatimage.clearAnimation();
	        LayoutParams lp = new LayoutParams(boatimage.getWidth(), boatimage.getHeight());
	        lp.setMargins(50, 100, 0, 0);
	        boatimage.setLayoutParams(lp);
	    }

	    @Override
	    public void onAnimationRepeat(Animation animation) {
	    }

	    @Override
	    public void onAnimationStart(Animation animation) {
	    }

	}
	*/

}
