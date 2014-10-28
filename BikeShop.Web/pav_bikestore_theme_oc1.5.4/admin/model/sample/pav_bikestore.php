<?php 
if( !class_exists("ModuleSample") ) {
	class ModuleSample { 
		public static function getModules(){ 
			$modules = array(
				'banner',
				'category',
				'pavblog',
				'pavblogcategory',
				'pavblogcomment',
				'pavbloglatest',
				'pavcustom',
				'pavproductcarousel',
				'special',
				'pavcontentslider',
				'bestseller',
				'pavmegamenubase',
				'pavnewsletter'
			);
			
			return $modules;
		}
		
		public static function getModulesQuery(){
			$query = array();
			require( dirname(__FILE__).'/pav_bikestore_query.php' );
			return $query;
		}
			public static function installCustomSetting( $m ){
			
				$d['pavblog'] = array(
							'children_columns' => '3',
							'general_cwidth' => '250',
							'general_cheight' => '145',
							'general_lwidth'=> '700',
							'general_lheight'=> '350',
							'general_sheight'=> '150',
							'general_swidth'=> '300',
							'general_xwidth' => '180',
							'general_xheight' => '90',
							'cat_show_hits' => '1',
							'cat_limit_leading_blog'=> '1',
							'cat_limit_secondary_blog'=> '3',
							'cat_leading_image_type'=> 's',
							'cat_secondary_image_type'=> 's',
							'cat_show_title'=> '1',
							'cat_show_image'=> '1',
							'cat_show_author'=> '1',
							'cat_show_category'=> '1',
							'cat_show_created'=> '1',
							'cat_show_readmore' => 1,
							'cat_show_description' => '1',
							'cat_show_comment_counter'=> '1',

							'blog_image_type'=> 'l',
							'blog_show_title'=> '1',
							'blog_show_image'=> '1',
							'blog_show_author'=> '1',
							'blog_show_category'=> '1',
							'blog_show_created'=> '1',
							'blog_show_comment_counter'=> '1',
							'blog_show_comment_form'=>'1',
							'blog_show_hits' => 1,
							'cat_columns_leading_blog'=> 1,
							'cat_columns_leading_blogs'=> 1,
							'cat_columns_secondary_blogs' => 1,
							'comment_engine' => 'local',
							'diquis_account' => 'pavothemes',
							'facebook_appid' => '100858303516',
							'facebook_width'=> '600',
							'comment_limit'=> '10',
							'auto_publish_comment'=>0,
							'enable_recaptcha' => 1,
							'recaptcha_public_key'=>'6LcoLd4SAAAAADoaLy7OEmzwjrf4w7bf-SnE_Hvj',
							'recaptcha_private_key'=>'6LcoLd4SAAAAAE18DL_BUDi0vmL_aM0vkLPaE9Ob',
							'rss_limit_item' => 12,
							'keyword_listing_blogs_page'=>'blogs'

				);

				$m->load->model('setting/setting');
				$m->model_setting_setting->editSetting('pavblog', $d );	
		}
		public static function getStoreConfigs(){
			return array(
					'config_image_category_width' =>700,
					'config_image_category_height' => 258,
					
					'config_image_thumb_width' =>500,
					'config_image_thumb_height' => 416,
					
					'config_image_popup_width' =>500,
					'config_image_popup_height' => 416,
					
					'config_image_product_width' =>500,
					'config_image_product_height' => 416,
					
					'config_image_additional_width' =>100,
					'config_image_additional_height' => 83,
					
					'config_image_related_width' =>500,
					'config_image_related_height' => 416,
					
					'config_image_compare_width' =>92,
					'config_image_compare_height' => 77,
					
					'config_image_wishlist_width' =>55,
					'config_image_wishlist_height' => 46,
					
					'config_image_cart_width' =>55,
					'config_image_cart_height' => 46,
			);
		}
	
	}
}
?>