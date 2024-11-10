import { Component, input} from '@angular/core';
import { CommonModule } from '@angular/common';
import { Message } from '../models/message';

@Component({
  selector: 'app-messages',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './messages.component.html',
  styleUrl: './messages.component.css'
})
export class MessagesComponent {
  // @Input() messages: Message[] = [];
  messages = input<Message[]>([]);
}
