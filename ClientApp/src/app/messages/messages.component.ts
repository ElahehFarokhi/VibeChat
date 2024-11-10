import { Component, Input} from '@angular/core';
import { CommonModule, NgFor } from '@angular/common';
import { Message } from '../models/message';

@Component({
  selector: 'app-messages',
  standalone: true,
  imports: [CommonModule, NgFor],
  templateUrl: './messages.component.html',
  styleUrl: './messages.component.css'
})
export class MessagesComponent {
  @Input() messages: Message[] = [];
}
