<?php

require_once 'Zend/Loader.php';
Zend_Loader::loadClass('Zend_Gdata');
Zend_Loader::loadClass('Zend_Gdata_AuthSub');
Zend_Loader::loadClass('Zend_Gdata_ClientLogin');
Zend_Loader::loadClass('Zend_Gdata_HttpClient');
Zend_Loader::loadClass('Zend_Gdata_Calendar');


$user = 'xxxxxxx@xxxxxx.com';
$pass = 'xxxxxxxxxx';
$service = Zend_Gdata_Calendar::AUTH_SERVICE_NAME; // predefined service name for calendar

$client = Zend_Gdata_ClientLogin::getHttpClient($user,$pass,$service);


function createEvent ($client, $title, $persona)
{
  $date_day = date("Y-m-d");
  $date_min = date("i") +1;
  $date_time = date("H:{$date_min}");
  $tzOffset = "+01";
  
  $gdataCal = new Zend_Gdata_Calendar($client);
  $newEvent = $gdataCal->newEventEntry();
  
  $newEvent->title = $gdataCal->newTitle($title);
  $newEvent->where = array($gdataCal->newWhere($persona));
  //$newEvent->content = $gdataCal->newContent("$desc");
  
  $when = $gdataCal->newWhen();
  $when->startTime = "{$date_day}T{$date_time}:00.000{$tzOffset}:00";
  $when->endTime = $when->startTime;
  $newEvent->when = array($when);
  
  $reminder = $gdataCal->newReminder();
$reminder->method = "sms";
$reminder->minutes = "0";

// Apply the reminder to an existing event's when property
$when = $newEvent->when[0];
$when->reminders = array($reminder);

  // Upload the event to the calendar server
  // A copy of the event as it is recorded on the server is returned
  $createdEvent = $gdataCal->insertEvent($newEvent);
  return $createdEvent->id->text;
}

$id_event = createEvent($client, 'Enviar un mensaje nunca fue tan facil','Rodrigo Arias');
    
    if ($id_event != null ){
	echo "Mensaje enviado!";
    }

echo $id_event;/*
setReminder($client,'dmrshm71ss81tbf9otruleq24k',0 );*/

?>
